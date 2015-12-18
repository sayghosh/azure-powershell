﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.Azure.Commands.Test.Utilities.Common;
using Xunit;

namespace Microsoft.Azure.Commands.Websites.Test.ScenarioTests
{
    public class WebAppTests : RMTestBase
    {
        private const string CallingClass = "Microsoft.Azure.Commands.Websites.Test.ScenarioTests.WebAppTests";

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCreateNewWebApp()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestCreateNewWebApp",
                "Test-CreateNewWebApp");
        }

        [Fact(Skip = "Needs investigation. Fails running playback")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetWebApp()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestGetWebApp",
                "Test-GetWebApp");
        }

        [Fact(Skip = "Needs investigation. Fails running playback")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetWebAppMetrics()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestGetWebAppMetrics",
                "Test-GetWebAppMetrics");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestWebAppPublishingProfile()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestWebAppPublishingProfile",
                "Test-WebAppPublishingProfile");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCloneNewWebApp()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestCloneNewWebApp",
                "Test-CloneNewWebApp");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCloneNewWebAppWithNewTrafficManager()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestCloneNewWebAppWithNewTrafficManager",
                "Test-CloneNewWebAppWithTrafficManager");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestStartStopRestartWebApp()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestStartStopRestartWebApp",
                "Test-StartStopRestartWebApp");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetWebApp()
        {
            WebsitesController.NewInstance.RunPsTest(
                CallingClass,
                "TestSetWebApp",
                "Test-SetWebApp");
        }
    }
}