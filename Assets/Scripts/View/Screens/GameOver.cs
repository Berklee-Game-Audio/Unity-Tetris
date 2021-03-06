﻿using UnityEngine;

public class GameOver : ScoreScreenType<GameOver>
{

    public override void ShowScreen(float timeToTween = TIME_TO_TWEEN)
    {
        SetLines(Score.instance.PlayerScore);
        base.ShowScreen(timeToTween);
    }

    public void ShowScreen(bool isWin, int levels, bool isDone, float timeToTween = TIME_TO_TWEEN)
    {
        SetLines(Score.instance.PlayerScore, isWin, levels, isDone );
        base.ShowScreen(timeToTween);
    }
}