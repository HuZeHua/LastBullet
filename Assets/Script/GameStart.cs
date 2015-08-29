using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {
    //这个函数放在Camera上，在点击“开始游戏”按钮的时候通过onclick控件，
    //找到camera对象，再调用下面的GameStartButton方法跳转场景
    public void GameStartButton() {
        Application.LoadLevel(1);
    }
}
