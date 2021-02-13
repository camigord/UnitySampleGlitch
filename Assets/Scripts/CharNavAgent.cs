using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Policies;

[System.Serializable]
public class CharNavAgent : Agent
{
	private GlobalConfig m_config;

	public override void Initialize()
	{
		m_config = FindObjectOfType<GlobalConfig>();	
		OnEpisodeBegin();	
	}

	public override void OnEpisodeBegin()
	{		
		
	}

	public void FixedUpdate() 
	{		
			
	}

	public override void CollectObservations(VectorSensor sensor)
	{
				
	}
	
	public override void OnActionReceived(float[] vectorAction)
	{	
			
	}

	public override void Heuristic(float[] actionsOut)
	{
		actionsOut[0] = Input.GetAxis("Vertical");
		actionsOut[1] = Input.GetAxis("Horizontal");
	}
}
