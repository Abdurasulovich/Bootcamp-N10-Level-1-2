// See https://aka.ms/new-console-template for more information


using Delegates.Example.Extensions;
using System.Runtime;

var userA = new List<User>
{
    new(Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"), "john", "doe"),
    new(Guid.Parse("A2DAD52F-639D-4EDC-AD5A-530C280A1017"), "jonibek", "doe")
};

var userB = new List<User>
{
    new(Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"), "johnson", "doe"),
    new(Guid.Parse("D0BAE6A0-9446-4561-8C39-3EA5EB4AE810"), "jane", "doe")
};

var skillsA = new List<TalentSkill>
{
    new (Guid.Parse("859F84D8-B4A6-434B-8C67-58D8061497E5"),
    Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"),
    "JavaScript",
    SkillLevel.Intermediate),
    new(Guid.Parse("092D9252-34BF-4E68-BE97-8B714A5DC3A4"), Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"), "TypeScript", SkillLevel.Beginner),
    new(Guid.Parse("1949ACA1-2FA2-474C-A967-5910EE08BC70"), Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"), "CSharp", SkillLevel.Advanced)

};

var skillsB = new List<TalentSkill>
{
    new(Guid.Parse("092D9252-34BF-4E68-BE97-8B714A5DC3A4"), Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"), "TS", SkillLevel.Intermediate),
    new(Guid.Parse("1949ACA1-2FA2-474C-A967-5910EE08BC70"), Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"), "CS", SkillLevel.Intermediate),
    new(Guid.Parse("859F84D8-B4A6-434B-8C67-58D8061497E5"), Guid.Parse("99E3BA84-B062-4132-A691-6EA6C720E3FB"), "JS", SkillLevel.Intermediate),
};


var intersectedSkills = skillsA.ZipIntersectBy(skillsB, skill => skill.Id);

foreach(var (previous, updatedSkill) in intersectedSkills)
{
    Console.WriteLine($"Skill eski qiymatlari - {previous.SkillName} : {previous.SkillLevel}");
    Console.WriteLine($"Skill yangi qiymatlari - {updatedSkill.SkillName} : {updatedSkill.SkillLevel}");
}


public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;

    public User(Guid id, string firstName, string lastName) 
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}

public enum SkillLevel
{
    Beginner, 
    Intermediate, 
    Advanced
}

public class TalentSkill
{
    public Guid Id { get; set; }
    public Guid TalentId { get; set; }

    public string SkillName { get; set; }

    public SkillLevel SkillLevel { get; set; }
    public TalentSkill(Guid id, Guid talentId, string skillName, SkillLevel skillLevel)
    {
        Id = id;
        TalentId = talentId;
        SkillName = skillName;
        SkillLevel = skillLevel;
    }
}












