// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LimitOrderAdapter.cs" company="LunchBox corp">
//     Copyright 2014 The Lunch-Box mob: 
//           Ozgur DEVELIOGLU (@Zgurrr)
//           Cyrille  DUPUYDAUBY (@Cyrdup)
//           Tomasz JASKULA (@tjaskula)
//           Mendel MONTEIRO-BECKERMAN (@MendelMonteiro)
//           Thomas PIERRAIN (@tpierrain)
//     
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//         http://www.apache.org/licenses/LICENSE-2.0
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SimpleOrderRouting.Infra
{
    using OtherTeam.StandardizedMarketGatewayAPI;

    /// <summary>
    /// Adapts LimitOrder between the SOR and the external market gateway models. 
    /// </summary>
    public class LimitOrderAdapter : OrderAdapter
    {
        private readonly ApiLimitOrder apiLimitOrder;

        public LimitOrderAdapter(ApiMarketGateway marketGateway, ApiLimitOrder apiLimitOrder)
            : base(marketGateway, apiLimitOrder)
        {
            this.apiLimitOrder = apiLimitOrder;
        }

        public override void Send()
        {
            this.MarketGateway.Send(this.apiLimitOrder);
        }
    }
}