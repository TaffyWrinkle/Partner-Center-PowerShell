﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.PowerShell.Commands
{
    using System.Management.Automation;
    using Models.Authentication;
    using Models.Partners;

    /// <summary>
    /// Gets the partner billing profile from Partner Center.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "PartnerBillingProfile")]
    [OutputType(typeof(PSBillingProfile))]
    public class GetPartnerBillingProfile : PartnerAsyncCmdlet
    {
        /// <summary>
        /// Executes the operations associated with the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            Scheduler.RunTask(async () =>
            {
                IPartner partner = await PartnerSession.Instance.ClientFactory.CreatePartnerOperationsAsync(CorrelationId, CancellationToken).ConfigureAwait(false);
                WriteObject(new PSBillingProfile(await partner.Profiles.BillingProfile.GetAsync(CancellationToken).ConfigureAwait(false)));
            }, true);
        }
    }
}