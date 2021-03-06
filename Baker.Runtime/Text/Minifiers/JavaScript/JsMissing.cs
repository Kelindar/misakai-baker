// missing.cs
//
// Copyright 2010 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Baker.Text
{

    internal sealed class JsMissing
    {
      // singleton implementation
      private static readonly JsMissing s_instance = new JsMissing();
      public static JsMissing Value
      {
        get
        {
          return s_instance;
        }
      }
    
      private JsMissing(){}

      public override string ToString()
      {
        return string.Empty;
      }
    }
}
