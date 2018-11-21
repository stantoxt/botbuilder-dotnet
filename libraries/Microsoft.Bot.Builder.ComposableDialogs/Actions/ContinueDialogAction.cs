﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;

namespace Microsoft.Bot.Builder.ComposableDialogs.Dialogs
{
    /// <summary>
    /// Replace the current Dialog with another dialog as an action
    /// </summary>
    public class ContinueDialogAction : IAction
    {
        public ContinueDialogAction() { }

        public async Task<DialogTurnResult> Execute(DialogContext dialogContext, object options, DialogTurnResult result, CancellationToken cancellationToken)
        {
            await dialogContext.ContinueDialogAsync(cancellationToken);

            return result;
        }
    }
}