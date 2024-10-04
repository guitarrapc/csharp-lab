```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,232.8 ns** |     **127.04 ns** |     **6.96 ns** |     **1,228.2 ns** |     **1,240.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,359.8 ns |      96.86 ns |     5.31 ns |     1,356.2 ns |     1,365.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,603.5 ns |      32.97 ns |     1.81 ns |     1,602.1 ns |     1,605.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,574.8 ns |     265.97 ns |    14.58 ns |     2,562.5 ns |     2,590.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.3 ns |      41.11 ns |     2.25 ns |       200.2 ns |       204.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.4 ns |      15.96 ns |     0.87 ns |       286.5 ns |       288.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       485.2 ns |      26.02 ns |     1.43 ns |       483.7 ns |       486.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,559,077.7 ns** | **174,085.49 ns** | **9,542.21 ns** | **1,552,225.8 ns** | **1,569,976.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,626.2 ns |   1,293.41 ns |    70.90 ns |   617,552.0 ns |   617,693.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,261.6 ns |  15,291.50 ns |   838.18 ns |   658,701.6 ns |   660,225.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,356.1 ns |  35,338.12 ns | 1,937.00 ns | 1,379,724.9 ns | 1,383,497.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,061.4 ns |     528.84 ns |    28.99 ns |   163,043.8 ns |   163,094.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    93,121.2 ns |   1,120.83 ns |    61.44 ns |    93,061.9 ns |    93,184.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    66,038.7 ns |   6,363.60 ns |   348.81 ns |    65,636.3 ns |    66,254.6 ns |      - |      40 B |
