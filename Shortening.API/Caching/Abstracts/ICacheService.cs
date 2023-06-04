﻿namespace Shortening.API.Caching.Abstracts
{
    public interface ICacheService
    {
        T GetData<T>(string key);

        bool SetData<T>(string key, T value, DateTimeOffset expirationTime);

        object RemoveData(string key);
    }
}
