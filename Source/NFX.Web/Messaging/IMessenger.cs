/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2017 ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.ApplicationModel;
using NFX.DataAccess.CRUD;
using NFX.Environment;
using NFX.Serialization.Arow;
using NFX.ServiceModel;

namespace NFX.Web.Messaging
{
    /// <summary>
    /// Describes an entity that can send EMails
    /// </summary>
    public interface IMessenger : IApplicationComponent
    {
      void SendMsg(Message msg);
    }

    public interface IMessengerImplementation : IMessenger, IConfigurable, IService, IApplicationFinishNotifiable
    {

    }
}
