namespace Oxide.Plugins
{
    [Info("Epic Stuff", "Unknown Author", "0.1.0")]
    [Description("Makes epic stuff happen")]
   
    #region Main
    class UmodPluginTemplate : CovalencePlugin
    {
        #region Initialization

        private void Init()
        {
            Puts("A baby plugin is born!");
        }
        
    #endregion

        // The rest of the code magic

        // TODO (you): Make more epic stuff
    }
    #endregion

    #region Config
    #endregion

    #region Localization
    #endregion

    #region Data Files
    #endregion

    #region Hooks
    #endregion

}
