﻿using AccidentalFish.Commanding.Model;

namespace AccidentalFish.Commanding.AzureEventHub
{
    public interface IPartitionKeyProvider
    {
        string GetPartitionKey(AuditItem auditItem);
    }
}
