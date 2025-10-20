using BeautyManager.Shared.Connection;
using BeautyManager.Shared.Models.Db;
using BeautyManager.Shared.Models.Local;
using BeautyManager.Web.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.IdentityModel.Tokens;

namespace BeautyManager.Web.Utils;

public class BookValidator
{
    public ErrorMessage ValidateData(List<BeautyBook> books, BeautyBook book, WorkingCard? selectedCard,
        BeautyTask? selectedTask, ErrorMessage errorMessage)
    {
        errorMessage.IsErrorOccured = false;

        if (selectedTask == null)
        {
            errorMessage.IsErrorOccured = true;
            errorMessage.Message = "Selected task is invalid.";
            return errorMessage;
        }

        if (selectedCard == null)
        {
            errorMessage.IsErrorOccured = true;
            errorMessage.Message = "Selected time slot is invalid.";
            return errorMessage;
        }

        if (book.CustomerName.IsNullOrEmpty() || book.CustomerName.Trim().Length < 2)
        {
            errorMessage.IsErrorOccured = true;
            errorMessage.Message = "Please enter a valid name.";
            return errorMessage;
        }

        if (book.CustomerPhone.IsNullOrEmpty() || book.CustomerPhone.Trim().Length < 5)
        {
            errorMessage.IsErrorOccured = true;
            errorMessage.Message = "Please enter a valid phone number.";
            return errorMessage;
        }

        DateTimeOffset endDate = selectedCard.StartDate.Add(selectedTask.TaskDuration.ToTimeSpan());
        if (books.Any(o =>
                o.ExecutingDate >= selectedCard.StartDate
                && o.ExecutingDate < endDate))
        {
            errorMessage.IsErrorOccured = true;
            errorMessage.Message = "The selected time slot is already booked or has passed.";
        }

        return errorMessage;
    }
}