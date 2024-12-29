﻿using UncomplicatedCustomAbilities.LIL.Attributes;
using UncomplicatedCustomAbilities.LIL.Enums;
using UncomplicatedCustomAbilities.LIL.Features.Script.Results;

namespace UncomplicatedCustomAbilities.LIL.Features.Script.Instructions
{
    [OpCodeReference(OpCodeType.Ret)]
    internal class Return(string raw, Script script) : Instruction(raw, script)
    {
        public override Result Execute() => new Results.Return();
    }
}