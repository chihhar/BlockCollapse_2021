using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class BarAgent : Agent
{
    int count;
    int count1;
    float time = 0f;
    public GameObject Bar;
    public GameObject ball;
    public GameObject[] blocks;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        Bar = GameObject.Find("Bar");
        blocks = GameObject.FindGameObjectsWithTag("Block");
    }
    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("Block").Length;
        count1 = GameObject.FindGameObjectsWithTag("Player").Length;
        time += Time.deltaTime;
    }
    /*
     *�G�s�\�[�h�J�n���̏���
     * �{�[�����������Ƃ��Q�[����ăX�^�[�g
     * �{�[���������Ă��Ȃ����Q�[����ăX�^�[�g�H
     * 
    */
    public override void OnEpisodeBegin()
    {   
        Reset();
    }

    /*Agent�Ɋϑ��l��n������
     * �o�[�̈ʒu
     * 
     */
    public override void CollectObservations(VectorSensor sensor)
    {
        // Target and Agent positions
        //sensor.AddObservation(Ball.localPosition);
        sensor.AddObservation(ball.GetComponent<Transform>().localPosition);
        sensor.AddObservation(Bar.GetComponent<Transform>().localPosition);
        // ���̈ړ����x
        sensor.AddObservation(ball.GetComponent<Rigidbody>().velocity.x);
        sensor.AddObservation(ball.GetComponent<Rigidbody>().velocity.y);
    }

    //�s�����s�@��V�̎擾�@�G�s�\�[�h����
    public override void OnActionReceived(ActionBuffers actionBuffers)
    {
        //int action = (int)actionBuffers[0];
        //if (action == 1) rigitbody.transform.Translate(0.5f, 0f, 0f);  // migi
        //if (action == 2) rigitbody.transform.Translate(-0.5f, 0f, 0f);  // hidari

        // �s���̎w�� actions, size=2
        

        if ((Bar.transform.position.x >= 20 && actionBuffers.ContinuousActions[0] > 0) || (Bar.transform.position.x <= -20) && actionBuffers.ContinuousActions[0] < 0)
        { }
        else
        {
            Bar.transform.Translate(0.5f * actionBuffers.ContinuousActions[0], 0f, 0f);
        }
        //Bar.GetComponent<Transform>().Translate(0.5f * (float)(actionBuffers.ContinuousActions[0] - actionBuffers.ContinuousActions[1]), 0.0f, 0.0f);
        //rBody.AddForce(controlSignal * forceMultiplier);

        // �^�[�Q�b�g�ɋ߂Â��Ă���Ε�V��^���ďI��
        float distanceToTarget = Vector3.Distance(Bar.GetComponent<Transform>().localPosition, ball.GetComponent<Transform>().localPosition);


        // �^�[�Q�b�g�ɋ߂Â��Ă���Ε�V��^���ďI��
        /*
        if (time > 0)
        {
            if (distanceToTarget < 5.0f)
            {
                SetReward(0.1f);
                time = -10f;
            }
            
        }
        */
        if (count == 0)
        {
            SetReward(1.0f);
            EndEpisode();
        }
        if (distanceToTarget < 5.0f) {
            SetReward(1.0f);
        }
        if (ball.transform.position.y < -41)
        {
            SetReward((20 - GameObject.FindGameObjectsWithTag("Block").Length) /20);
            EndEpisode();
        }
    }

    //�蓮���s����OnActionReceived��ActionBuffers��n������
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        
        var continuousActionsOut = actionsOut.ContinuousActions;
        continuousActionsOut[0] = Input.GetAxis("Horizontal");
        //continuousActionsOut[1] = Input.GetAxis("Vertical");
        
    }
    //�@�f�[�^�̏��������\�b�h
    public void Reset()
    {
        ball.transform.localPosition = new Vector3(0f, 0f, 0f);
        Bar.transform.localPosition = new Vector3(0f,-40.6f,0f);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().AddForce(new Vector3(10.0f, -10.0f, 0.0f) * 100);
        
        for (int i = 0; i < blocks.Length; i++)
        {
            blocks[i].SetActive(true);
        }
    }
}