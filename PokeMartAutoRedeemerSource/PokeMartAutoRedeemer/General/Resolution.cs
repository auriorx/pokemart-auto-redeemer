using System.Collections.Generic;

namespace PokeMartAutoRedeemer.General
{
    public static class Resolution
    {
        #region Public Field

        public static Dictionary<string, Dictionary<string, (int x, int y)>> ResolutionStepDictionary =
            new Dictionary<string, Dictionary<string, (int x, int y)>>
            {
                {
                    "2560x1440", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (687, 1190)},
                        {"clickOnAddCode", (705, 1309)},
                        {"clickOnSubmitCodes", (1585, 1308)},
                        {"clickOnDuplicateErrorOkButton", (1275, 825)},
                        {"clickOnSubmitCodesDoneButton", (1102, 1309)},
                    }
                },
                {
                    "1920x1200", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (485, 981)},
                        {"clickOnAddCode", (495, 1081)},
                        {"clickOnSubmitCodes", (1211, 1084)},
                        {"clickOnDuplicateErrorOkButton", (956, 689)},
                        {"clickOnSubmitCodesDoneButton", (814, 1083)},
                    }
                },
                {
                    "1920x1080", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (514, 893)},
                        {"clickOnAddCode", (527, 980)},
                        {"clickOnSubmitCodes", (1191, 982)},
                        {"clickOnDuplicateErrorOkButton", (959, 619)},
                        {"clickOnSubmitCodesDoneButton", (829, 981)},
                    }
                },
                {
                    "1680x1050", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (0, 0)},
                        {"clickOnAddCode", (0, 0)},
                        {"clickOnSubmitCodes", (0, 0)},
                        {"clickOnDuplicateErrorOkButton", (0, 0)},
                        {"clickOnSubmitCodesDoneButton", (0, 0)},
                    }
                },
                {
                    "1600x1200", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (0, 0)},
                        {"clickOnAddCode", (0, 0)},
                        {"clickOnSubmitCodes", (0, 0)},
                        {"clickOnDuplicateErrorOkButton", (0, 0)},
                        {"clickOnSubmitCodesDoneButton", (0, 0)},
                    }
                },
                {
                    "1600x900", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (0, 0)},
                        {"clickOnAddCode", (0, 0)},
                        {"clickOnSubmitCodes", (0, 0)},
                        {"clickOnDuplicateErrorOkButton", (0, 0)},
                        {"clickOnSubmitCodesDoneButton", (0, 0)},
                    }
                },
                {
                    "1280x720", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (0, 0)},
                        {"clickOnAddCode", (0, 0)},
                        {"clickOnSubmitCodes", (0, 0)},
                        {"clickOnDuplicateErrorOkButton", (0, 0)},
                        {"clickOnSubmitCodesDoneButton", (0, 0)},
                    }
                },
                {
                    "0x0", new Dictionary<string, (int x, int y)>
                    {
                        {"clickOnCodeBox", (0, 0)},
                        {"clickOnAddCode", (0, 0)},
                        {"clickOnSubmitCodes", (0, 0)},
                        {"clickOnDuplicateErrorOkButton", (0, 0)},
                        {"clickOnSubmitCodesDoneButton", (0, 0)},
                    }
                },
            };

        #endregion
    }
}
