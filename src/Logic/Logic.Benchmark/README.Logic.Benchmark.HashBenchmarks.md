```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,326.8 ns** |     **28.68 ns** |     **1.57 ns** |     **1,325.7 ns** |     **1,328.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,484.4 ns |     82.06 ns |     4.50 ns |     1,480.2 ns |     1,489.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,718.2 ns |    323.01 ns |    17.71 ns |     1,698.3 ns |     1,732.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,660.9 ns |     86.92 ns |     4.76 ns |     2,655.6 ns |     2,664.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.7 ns |     12.87 ns |     0.71 ns |       201.9 ns |       203.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.2 ns |     23.67 ns |     1.30 ns |       290.3 ns |       292.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       476.0 ns |     12.34 ns |     0.68 ns |       475.3 ns |       476.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,226.5 ns** |  **4,439.85 ns** |   **243.36 ns** | **1,546,020.9 ns** | **1,546,495.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,189.6 ns |    656.50 ns |    35.99 ns |   614,148.1 ns |   614,212.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,517.1 ns | 12,822.79 ns |   702.86 ns |   655,082.9 ns |   656,328.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,440.0 ns | 20,932.43 ns | 1,147.38 ns | 1,372,569.7 ns | 1,374,740.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,730.2 ns | 10,087.41 ns |   552.93 ns |   162,307.3 ns |   163,355.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,831.3 ns | 44,102.50 ns | 2,417.41 ns |    91,426.0 ns |    95,622.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,359.2 ns |    833.93 ns |    45.71 ns |    65,332.3 ns |    65,412.0 ns |      - |      40 B |
