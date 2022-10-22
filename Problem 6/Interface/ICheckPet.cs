using System;

internal interface ICheckPet
{
    public string PetName { get; set; }
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
}