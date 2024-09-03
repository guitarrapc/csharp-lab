```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,317.2 ns** |    **103.27 ns** |     **5.66 ns** |     **1,313.3 ns** |     **1,323.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,459.6 ns |    158.12 ns |     8.67 ns |     1,452.5 ns |     1,469.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,698.1 ns |    207.17 ns |    11.36 ns |     1,685.2 ns |     1,706.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,725.4 ns |  1,414.18 ns |    77.52 ns |     2,635.9 ns |     2,771.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       250.1 ns |     30.20 ns |     1.66 ns |       248.2 ns |       251.3 ns | 0.0067 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.9 ns |     36.26 ns |     1.99 ns |       284.7 ns |       288.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       473.2 ns |     20.40 ns |     1.12 ns |       472.0 ns |       474.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,405.9 ns** |    **954.60 ns** |    **52.33 ns** | **1,545,349.0 ns** | **1,545,452.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,728.5 ns | 19,394.32 ns | 1,063.07 ns |   614,044.7 ns |   615,953.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,441.1 ns | 26,025.88 ns | 1,426.57 ns |   654,826.5 ns |   657,531.0 ns |      - |      69 B |
| SHA512Binary    | Byte[1048576]       | 1,374,106.0 ns | 37,564.02 ns | 2,059.01 ns | 1,372,837.9 ns | 1,376,481.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,363.9 ns |  5,824.46 ns |   319.26 ns |   162,172.3 ns |   162,732.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,576.3 ns |  1,412.96 ns |    77.45 ns |    91,486.9 ns |    91,624.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,351.0 ns |  1,135.45 ns |    62.24 ns |    65,289.5 ns |    65,414.0 ns |      - |      40 B |
