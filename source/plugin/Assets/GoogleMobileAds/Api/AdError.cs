// Copyright (C) 2020 Google, LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using GoogleMobileAds.Common;
namespace GoogleMobileAds.Api
{
    /// <summary>
    /// Gets error information about why an ad load operation failed.
    /// </summary>
    /// <returns>Ad Error Object with Code, Message, Domain, and Cause.</returns>
    public class AdError
    {
        private IAdErrorClient client;
        public AdError(IAdErrorClient client)
        {
            this.client = client;

        }
        public int GetCode()
        {
            return client.GetCode();
        }
        public string GetDomain()
        {
            return client.GetDomain();
        }

        public string GetMessage()
        {
            return client.GetMessage();
        }

        public AdError GetCause()
        {
            return new AdError(client.GetCause());
        }

        public override string ToString()
        {
            return client.ToString();
        }
    }
}

