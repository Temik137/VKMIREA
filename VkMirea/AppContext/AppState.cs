using System;

namespace VkMirea.AppContext
{
    public static class AppState
    {
        public static ModeState AppModeState = ModeState.None;
        public static LoginState LoginState = LoginState.Unauthorized;
        public static Guid AppGuid = Guid.NewGuid();
    }

    public enum ModeState
    {
        None,
        Training,
        Examine
    }

    public enum LoginState
    {
        Authorized,
        Unauthorized
    }
}