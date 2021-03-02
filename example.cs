using System.Threading.Tasks;


public class Example {

    const string NamePattern = "[\\w-._]+";

    // Does not trigger CA1802
    static readonly string HeyRobotPattern = $@"(?:(?:hey|yo|hi(ya)?|hello|howdy)\s+)?@(?<robot>{NamePattern})\s+";

    // Trigger CA1802 which proves the rule is running
    static readonly string HeyRobotPattern2 = $"example";

    // Trigger CA1802 which proves the rule is running
    static readonly string HeyRobotPattern3 = "example";

}
