```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,319.8 ns** |      **31.23 ns** |      **1.71 ns** |     **1,318.1 ns** |     **1,321.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,453.9 ns |      88.24 ns |      4.84 ns |     1,448.4 ns |     1,457.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,711.3 ns |      40.64 ns |      2.23 ns |     1,708.8 ns |     1,712.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,652.2 ns |     228.43 ns |     12.52 ns |     2,644.6 ns |     2,666.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       210.4 ns |      42.40 ns |      2.32 ns |       208.0 ns |       212.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.1 ns |      17.27 ns |      0.95 ns |       286.1 ns |       288.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       488.8 ns |      11.96 ns |      0.66 ns |       488.0 ns |       489.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,143.9 ns** |  **18,941.03 ns** |  **1,038.22 ns** | **1,545,427.0 ns** | **1,547,334.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,130.7 ns |   2,174.08 ns |    119.17 ns |   614,043.6 ns |   614,266.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,728.6 ns |  25,721.14 ns |  1,409.86 ns |   654,908.1 ns |   657,356.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,385,011.3 ns | 322,510.51 ns | 17,677.89 ns | 1,374,490.7 ns | 1,405,420.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,391.0 ns |   4,808.21 ns |    263.55 ns |   162,178.4 ns |   162,685.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,721.0 ns |   5,714.38 ns |    313.22 ns |    91,448.9 ns |    92,063.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,946.2 ns |   2,092.14 ns |    114.68 ns |    64,844.3 ns |    65,070.4 ns |      - |      40 B |
