using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FlurrySDK;

public class FlurryManager : Singleton<FlurryManager>
{
#if UNITY_ANDROID
    private string FLURRY_API_KEY = "KZ7ZSDJTYYXZG5QDGVM5";
#elif UNITY_IPHONE
    private string FLURRY_API_KEY = "1";
#else
    private string FLURRY_API_KEY = null;
#endif

    public void Init()
    {
        // Initialize Flurry.
        new Flurry.Builder()
                  .WithCrashReporting(true)
                  .WithLogEnabled(true)
                  .WithLogLevel(Flurry.LogLevel.VERBOSE)
                  .WithMessaging(true)
                  .Build(FLURRY_API_KEY);
    }
}
