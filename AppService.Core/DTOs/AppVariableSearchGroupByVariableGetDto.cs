// Decompiled with JetBrains decompiler
// Type: AppService.Core.DTOs.AppVariableSearchGroupByVariableGetDto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.DTOs
{
    public class AppVariableSearchGroupByVariableGetDto
    {
        public int? AppVariableId { get; set; }

        public string VariableDescription { get; set; }

        public List<AppVariableSearchGetDto> AppVariableSearchGetDto { get; set; }
    }
}
