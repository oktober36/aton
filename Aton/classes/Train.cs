namespace Aton.classes;

public class Train
{
   private class Wagon
    {
        private bool _light; // 0 - off, 1 - on

        public Wagon(bool light)
        {
            this._light = light;
        }

        public void SetLight(bool light)
        {
            this._light = light;
        }

        public bool ToggleLight()
        {
            this._light = !_light;
            return _light;
        }


        public bool GetLight()
        {
            return _light;
        }
    }

    private int _currentPosition;

    private readonly List<Wagon> _wagons;

    public void Move(int movement)
    {
        _currentPosition = (_currentPosition + movement) % _wagons.Count;
        if (_currentPosition < 0) _currentPosition += _wagons.Count;
    }

    public bool GetCurrentLight()
    {
        return _wagons[_currentPosition].GetLight();
    }

    public void SetCurrentLight(bool light)
    {
        _wagons[_currentPosition].SetLight(light);
    }


    public Train(int minLenght, int maxLenght)
    {
        var rnd = new Random();
        var lenght = rnd.Next(minLenght, maxLenght + 1);
        _wagons = new List<Wagon>(lenght);
        
        for (var i = 0; i < lenght; i++)
            _wagons.Add(new Wagon(rnd.Next(2) == 1));

        _currentPosition = rnd.Next(0, lenght);
    }

    public int GetWagonsCount()
    {
        return _wagons.Count;
    }
}