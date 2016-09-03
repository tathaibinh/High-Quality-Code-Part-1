﻿namespace Task_2.RefactorFollowingStatements
{
    public class Cooker
    {
        public bool CheckIfPotatoIsReadyForCooking(Potato potato)
        {

            if (potato != null)
            {
                if (potato.IsPilled && potato.IsNotRotten)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Cook(Potato potato)
        {
            if (CheckIfPotatoIsReadyForCooking(potato))
            {
                potato.IsCooked = true;
            }
        }
    }
}