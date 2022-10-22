using System;

internal class Robot : ICheckRobot
{
    private string _robotname = "None";
    private string _Id = "None";

    public Robot(string robot, string robotoid)
    {
        Model = robot;
        Id = robotoid;
    }

    public string Model
    {
        get
        {
            return _robotname;
        }
        set
        {
            if (_robotname.Length < 3)
            {
                throw new Exception("The name must be longer than 3 characters ");
            }
            _robotname = value;
        }
    }

    public string Id
    {
        get
        {
            return _Id;
        }
        set
        {
            if (_Id.Length < 4 || _Id.Length > 11)
            {
                throw new Exception("ID must be between 4 and 11");
            }
            _Id = value;
        }
    }
}
