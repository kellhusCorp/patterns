﻿namespace MediatrExample.Responses;

public class PongResponse
{
    public DateTime Timestamp;

    public PongResponse(DateTime timestamp)
    {
        Timestamp = timestamp;
    }
}