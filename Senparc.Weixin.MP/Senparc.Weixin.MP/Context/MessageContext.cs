﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.Entities;

namespace Senparc.Weixin.MP.Context
{

    public interface IMessageContext: Weixin.Context.IMessageContext<IRequestMessageBase, IResponseMessageBase>
    {
    }

    public class MessageContext : Weixin.Context.MessageContext<IRequestMessageBase, IResponseMessageBase>, IMessageContext
    {
    }
}