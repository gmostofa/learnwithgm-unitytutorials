using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int coins = 100;
    public int level = 5;

    public void SavePlayer()
    {
        PlayerData data = new PlayerData();
        data.coins = coins;
        data.level = level;
        data.position = new float[]{transform.position.x, transform.position.y, transform.position.z};
        
        SaveSystem.Save(data);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.Load();

        if (data != null)
        {
            coins = data.coins;
            level = data.level;
            Vector3 pos = new Vector3(data.position[0], data.position[1], data.position[2]);
            transform.position = pos;
        }
    }
}
