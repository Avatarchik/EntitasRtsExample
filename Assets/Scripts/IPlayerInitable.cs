﻿using Entitas;

public interface IPlayerInitable
{
    void Init(Pool pool, int playerId);

    Entity Entity { get; }
}