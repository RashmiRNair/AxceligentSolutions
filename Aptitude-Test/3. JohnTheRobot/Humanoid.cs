using System;

namespace JohnTheRobot
{
    public class Humanoid 
    {
        private IRoboticSkills roboticSkill;
        public Humanoid(IRoboticSkills Skill)
        {
            this.roboticSkill = Skill;
        }

        public Humanoid() { }
        
        public String ShowSkill()
        {
            if (roboticSkill == null)
                return "no skill is defined";
            else
                return roboticSkill.GetSkill();
          }
    }
}
