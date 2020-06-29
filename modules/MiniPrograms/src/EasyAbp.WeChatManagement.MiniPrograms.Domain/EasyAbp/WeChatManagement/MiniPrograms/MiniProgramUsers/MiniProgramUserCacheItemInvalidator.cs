﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace EasyAbp.WeChatManagement.MiniPrograms.MiniProgramUsers
{
    public class MiniProgramUserCacheItemInvalidator : ILocalEventHandler<EntityChangedEventData<MiniProgramUser>>, ITransientDependency
    {
        public virtual Task HandleEventAsync(EntityChangedEventData<MiniProgramUser> eventData)
        {
            // Todo: remove cache, refer to: https://github.com/abpframework/abp/blob/1a622bc50fbd9b554f61078d5eeafa9def3216e3/modules/permission-management/src/Volo.Abp.PermissionManagement.Domain/Volo/Abp/PermissionManagement/PermissionGrantCacheItemInvalidator.cs
            return Task.CompletedTask;
        }
    }
}