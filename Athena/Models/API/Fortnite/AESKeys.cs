﻿namespace Athena.Models.API.Fortnite;

public class AESKeys
{
    public string MainKey;
    public List<DynamicKey> DynamicKeys;
}

public class DynamicKey
{
    public string Name;
    public string Key;
    public string Guid;
}