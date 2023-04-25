using UnityEngine;

[System.Serializable]
public class SizeDownPowerUp: GenericPowerUp{

    public SizeDownPowerUp(string name, bool isActive, int quantity, float cooldown, float cooldownTimer):base(name, isActive, quantity, cooldown, cooldownTimer){}

    public override void ObtainPowerUp(){
        base.ObtainPowerUp();
        Player.Instance.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public override bool CheckCondition(){
        return (Player.Instance.transform.localScale.x >= .3f);
    }
}

[System.Serializable]
public class LifeUpPowerUp: GenericPowerUp{

    public LifeUpPowerUp(string name, bool isActive, int quantity, float cooldown, float cooldownTimer):base(name, isActive, quantity, cooldown, cooldownTimer){}

    public override void ObtainPowerUp(){
        base.ObtainPowerUp();
        Player.Instance.lifes ++;
    }

    public override bool CheckCondition(){
        return Player.Instance.lifes <= 5f;
    }
}

// [System.Serializable]
// public class SlowDownPowerUp: GenericPowerUp{

//     public SlowDownPowerUp(string name, bool isActive, int quantity, float cooldown, float cooldownTimer):base(name, isActive, quantity, cooldown, cooldownTimer){}

//     public override void ObtainPowerUp(){
//         base.ObtainPowerUp();
//         this.cooldown = 11 - quantity*1;
//     }

//     public override void ActivatePowerUp(){
//         if(this.cooldownTimer >= WaveManager.Instance._waveTime+cooldown){
//             this.cooldownTimer = WaveManager.Instance._waveTime;
//         }
//     }

//     public override bool CheckCondition(){
//         return ClockManager.Instance._clockCount < ClockManager.Instance.MAX_CLOCKS;
//     }
// }


[System.Serializable]
public class AddClockPowerUp: GenericPowerUp{

    public AddClockPowerUp(string name, bool isActive, int quantity, float cooldown, float cooldownTimer):base(name, isActive, quantity, cooldown, cooldownTimer){}

    public override void ObtainPowerUp(){
        base.ObtainPowerUp();
        ClockManager.Instance._clockCount++;
    }

    public override bool CheckCondition(){
        return ClockManager.Instance._clockCount < ClockManager.Instance.MAX_CLOCKS;
    }
}


[System.Serializable]
public class EnemySpeedDownPowerUp: GenericPowerUp{

    public EnemySpeedDownPowerUp(string name, bool isActive, int quantity, float cooldown, float cooldownTimer):base(name, isActive, quantity, cooldown, cooldownTimer){}

    public override void ObtainPowerUp(){
        base.ObtainPowerUp();
        EnemyManager.Instance.enemyData.MultiplySpeedPowerUp(0.1f);
    }

    public override bool CheckCondition(){
        return EnemyManager.Instance.enemyData.speedMultiplierPowerUp > .1f;
    }
}

[System.Serializable]
public class EnemySizeDownPowerUp: GenericPowerUp{

    public EnemySizeDownPowerUp(string name, bool isActive, int quantity, float cooldown, float cooldownTimer):base(name, isActive, quantity, cooldown, cooldownTimer){}

    public override void ObtainPowerUp(){
        base.ObtainPowerUp();
        EnemyManager.Instance.enemyData.MultiplySizePowerUp(0.05f);
    }

    public override bool CheckCondition(){
        return EnemyManager.Instance.enemyData.sizeMultiplierPowerUp > .3f;
    }
}

[System.Serializable]
public class GuardianPowerUp: GenericPowerUp{

    public GuardianPowerUp(string name, bool isActive, int quantity, float cooldown, float cooldownTimer):base(name, isActive, quantity, cooldown, cooldownTimer){}

    public override void ObtainPowerUp(){
        base.ObtainPowerUp();
        
    }

    public override bool CheckCondition(){
        return EnemyManager.Instance.enemyData.sizeMultiplierPowerUp > .3f;
    }
}