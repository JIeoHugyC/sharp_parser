namespace sharp_parser;

public class User
{
    public User()
    {
        id = 7;
        _address = new Address();
    }
    public void FromJson()
    {
    }

    public void FromYaml()
    {
    }

    public int id;
    private Address _address;

}