```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error       | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,241.9 ns** |    **83.60 ns** |   **4.58 ns** |     **1,238.0 ns** |     **1,247.0 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,362.2 ns |    60.73 ns |   3.33 ns |     1,360.0 ns |     1,366.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,608.9 ns |   385.18 ns |  21.11 ns |     1,596.2 ns |     1,633.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,581.5 ns |    53.87 ns |   2.95 ns |     2,578.7 ns |     2,584.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       204.2 ns |    13.43 ns |   0.74 ns |       203.8 ns |       205.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       293.7 ns |    20.07 ns |   1.10 ns |       292.9 ns |       295.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.0 ns |    22.58 ns |   1.24 ns |       492.8 ns |       495.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,880.5 ns** | **8,165.70 ns** | **447.59 ns** | **1,553,365.7 ns** | **1,554,177.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,636.4 ns | 3,153.14 ns | 172.83 ns |   617,500.2 ns |   617,830.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,615.8 ns | 8,648.67 ns | 474.06 ns |   659,139.4 ns |   660,087.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,380,706.5 ns | 8,806.86 ns | 482.73 ns | 1,380,290.4 ns | 1,381,235.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,284.4 ns | 5,172.87 ns | 283.54 ns |   163,104.9 ns |   163,611.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,064.2 ns | 3,476.06 ns | 190.53 ns |    91,925.3 ns |    92,281.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,944.9 ns | 5,703.39 ns | 312.62 ns |    65,680.6 ns |    66,290.0 ns |      - |      40 B |
