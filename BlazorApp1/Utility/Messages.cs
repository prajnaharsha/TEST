namespace LitHold.Utility
{
    /// <summary>
    /// Provides a collection of messages used in the application
    /// </summary>
    public static class Messages
    {
        public const string GENERAL_APPLICATION_ERROR = "There was an error when processing your request. Please try again";
        public const string LITHOLD_MATTER_LOAD_ERROR = "There was an error when retrieving Lithold matters";
        public const string LITHOLD_RUNNING_STATUS_ERROR = "There was an error when retrieving Lithold running status";
        public const string LIHOLD_EXECUTION_ERROR = "There was an error when executing the lithold. Please try again";
        public const string LIHOLD_EXECUTION_FILE_COPY_ERROR = "There was an error while copying the attached document to destination directory.";
        public const string LIHOLD_EXECUTION_REQUEST_DOC_NUMBER_RETRIEVAL_ERROR = "Unable to retrieve Lithold Request Document Number";
        public const string LIHOLD_EXECUTION_BASE_PATH_NOT_FOUND = "Unable to locate the destination directory path to copy the attached file";
        public const string LIHOLD_RUNNING_STATUS_MESSAGE = "While the LitHold is running, monitor status with this screen, or click 'Close Monitoring Screen' to close the LitHold app.The LitHold you just started will continue to process until it's finished.";
        public const string PREVIOUS_LIHOLD_RUNNING_STATUS_MESSAGE = "A LitHold is currently running.  Since only one LitHold can run at a time, you can monitor status with this screen, or click 'Close Monitoring Screen'.  The LitHold you just started will continue to process until it's finished.";
        public const string HOLD_REQUEST_FORM_VALIDATION_MESSAGE = "You must select a Litigation Hold request form to attach to this matter before executing the Hold";
        public const string HOLD_END_DATE_REQUIRED_MESSAGE = "Hold End date cannot be empty.";
        public const string HOLD_START_DATE_REQUIRED_MESSAGE = "Hold Start date cannot be empty.";
        public const string HOLD_DATE_RANGE_VALIDATION_MESSAGE = "Hold End date cannot be earlier than Hold Start Date.";
        public const string NO_RESULTS_FOUND_SERACH_BY_MATTER_DESC = "No results found for Matter description";
        public const string NO_RESULTS_FOUND_SERACH_BY_MATTER_ID = "No results found for MatterID '{0}'";
        public const string RECORD_RETURN_LIMIT_MESSAGE = "The current search return limit is {0} records. Your search will return {1} records. Please refine or change the limit in Settings.";
        public const string LITHOLD_SUCCESS_MESSAGE = "All docket events, documents, and notes on MatterID {0} have been put on hold.";
        public const string APPLICATION_LOAD_ERROR = "We encountered an unexpected error while processing your request. We apologize for the inconvenience. Please try again later. If the problem persists, contact our support team for assistance..";
        public const string PAGE_NOT_FOUND_ERROR = "Sorry, there's nothing at this address";
        public const string PROCESSING_REQUEST = " Processing your request. Please wait ...";        
    }
}
