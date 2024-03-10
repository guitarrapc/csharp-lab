```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,314.8 ns** |     **92.44 ns** |     **5.07 ns** |     **1,310.3 ns** |     **1,320.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,459.0 ns |    131.88 ns |     7.23 ns |     1,454.4 ns |     1,467.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,722.7 ns |    423.44 ns |    23.21 ns |     1,708.2 ns |     1,749.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,724.3 ns |    840.16 ns |    46.05 ns |     2,690.4 ns |     2,776.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       227.8 ns |     19.39 ns |     1.06 ns |       226.6 ns |       228.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       280.0 ns |     21.85 ns |     1.20 ns |       279.0 ns |       281.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       505.2 ns |     22.10 ns |     1.21 ns |       503.8 ns |       506.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,924.0 ns** | **37,091.29 ns** | **2,033.10 ns** | **1,545,557.9 ns** | **1,549,260.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,187.7 ns |  1,232.17 ns |    67.54 ns |   614,110.0 ns |   614,232.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,736.7 ns | 39,672.13 ns | 2,174.56 ns |   654,996.5 ns |   659,174.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,792.1 ns | 70,444.69 ns | 3,861.31 ns | 1,372,266.4 ns | 1,379,236.9 ns |      - |     114 B |
| XxHash32Binary  | Byte[1048576]       |   163,522.7 ns | 39,970.24 ns | 2,190.90 ns |   162,112.8 ns |   166,046.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,995.4 ns |    847.50 ns |    46.45 ns |    91,945.2 ns |    92,036.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,654.8 ns | 13,091.26 ns |   717.58 ns |    65,020.8 ns |    66,433.8 ns |      - |      40 B |
