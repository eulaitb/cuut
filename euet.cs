public bool IsResponseSuccessful(HttpResponseMessage response)
{
    // Check if the response is not null to avoid NullReferenceException.
    if (response == null)
    {
        throw new ArgumentNullException(nameof(response), "The response object cannot be null.");
    }

    // Compare the status code of the response to HttpStatusCode.OK (200).
    // Return true if they are equal, indicating a successful response.
    return response.StatusCode == HttpStatusCode.OK;
}
