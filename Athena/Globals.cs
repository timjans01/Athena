﻿global using Serilog;

public static class Globals
{
    public const string VERSION = "1.3.0";
    public const string APPID = "1142239120471634042";

    // endpoints
    public const string MAPPINGS = "https://fortnitecentral.genxgames.gg/api/v1/mappings";
    public const string AESKEYS = "https://fortnitecentral.genxgames.gg/api/v1/aes";
    public const string BACKUPS = "https://api.fmodel.app/v1/backups/fortnitegame";
    public const string AUTH = "https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token";
    public const string MANIFEST = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/public/assets/v2/platform/Windows/namespace/fn/catalogItem/4fe75bbc5a674f4f9b356b5c90567da5/app/Fortnite/label/Live";

    // auth
    public const string BASIC = "basic MzQ0NmNkNzI2OTRjNGE0NDg1ZDgxYjc3YWRiYjIxNDE6OTIwOWQ0YTVlMjVhNDU3ZmI5YjA3NDg5ZDMxM2I0MWE=";
}