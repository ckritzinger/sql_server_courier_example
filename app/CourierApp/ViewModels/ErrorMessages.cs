using CourierApp.Data;

namespace CourierApp.ViewModels;

public static class ErrorMessages
{
    /// <summary>
    /// The banner text for a write the server refused, with the server's own reason, e.g.
    /// "Stop 4: your 'delivered' wasn't saved. Dispatch cancelled this stop."
    /// </summary>
    public static string For(Rejection rejection) =>
        $"Stop {rejection.StopSequence}: your '{rejection.Outcome}' wasn't saved. {rejection.Error}";
}
