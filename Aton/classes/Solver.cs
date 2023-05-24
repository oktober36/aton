namespace Aton.classes;

public static class Solver
{
    public static int Solve(Train train)
    {
        var stepNum = 0;
        train.SetCurrentLight(true);

        while (true)
        {
            stepNum += 1;
            train.Move(1);

            if (!train.GetCurrentLight())
                continue;
            
            train.SetCurrentLight(false);
            train.Move(-stepNum);
            if (!train.GetCurrentLight())
                break;
            
            train.Move(stepNum);
        }

        return stepNum;
    }
}