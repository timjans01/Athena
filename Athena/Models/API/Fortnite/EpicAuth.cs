﻿using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Athena.Models.API.Fortnite;

public class EpicAuth
{
    [J("access_token")] public string AccessToken;
    [J("expires_at")] public DateTime ExpiresAt;
}
