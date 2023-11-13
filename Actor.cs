// 8. 클래스
public class Actor {
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float stat;
    public int level;

    public string Talk()
    {
        return "대화";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level++ ;
    }


}