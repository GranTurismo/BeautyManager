using BeautyManager.Shared.Models.Db;
using BeautyManager.Web.Models;

namespace BeautyManager.Web.Utils;

public class BookCancelValidator
{
    public ErrorMessage ValidateCancellation(string code, BeautyBook book,ErrorMessage errorMessage)
    {
        if (code != book.CancellationCode.ToString())
        {
            errorMessage.IsErrorOccured = true;
            errorMessage.Message = "The cancellation code is incorrect.";
        }

        return errorMessage;
    }
}