using System.Threading.Tasks;


public class Example {

    const string NamePattern = "[\\w-._]+";

    // Does not trigger CA1802
    static readonly string HeyRobotPattern = $@"(?:(?:hey|yo|hi(ya)?|hello|howdy)\s+)?@(?<robot>{NamePattern})\s+";

    // Does not trigger CA1802. This is a simpler version of HeyRobotPattern that is trivially understood to be const
    static readonly string HeyRobotPattern2 = $"example";

    // Trigger CA1802 which proves the rule is running in general.
    static readonly string HeyRobotPattern3 = "example";

}
