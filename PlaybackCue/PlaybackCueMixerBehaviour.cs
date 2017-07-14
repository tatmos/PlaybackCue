using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class PlaybackCueMixerBehaviour : PlayableBehaviour
{
  
    CriAtomSource m_AtomSource;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        m_AtomSource = playerData as CriAtomSource;

        if (m_AtomSource == null)
            return;
        
        float inputWeight = 0;
        int inputCount = playable.GetInputCount ();
        for (int i = 0; i < inputCount; i++)
        {  
            inputWeight = playable.GetInputWeight(i);

            if(inputWeight == 1){

                ScriptPlayable<PlaybackCueBehaviour> inputPlayable = (ScriptPlayable<PlaybackCueBehaviour>)playable.GetInput(i);
                PlaybackCueBehaviour input = inputPlayable.GetBehaviour ();

                if(input.cueName != String.Empty)
                {
                    m_AtomSource.cueName = input.cueName;
                }

                CriAtomSource.Status status = m_AtomSource.status;
                if ((status == CriAtomSource.Status.Stop) || (status == CriAtomSource.Status.PlayEnd)) 
                {//停止かエンドか
                    m_AtomSource.Play();
                }

            } 
        }
    

    }

    public override void OnGraphStop (Playable playable)
    {

    }

}


