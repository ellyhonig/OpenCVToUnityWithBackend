using SimpleSQL;
public class Namegetter
{
    // The WeaponID field is set as the primary key in the SQLite
   
    // so we reflect that here with the PrimaryKey attribute
    [PrimaryKey]
  


    public string name { get; set; }
    public string ID { get; set; }
}