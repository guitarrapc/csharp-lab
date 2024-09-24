```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,273.7 ns** |    **610.82 ns** |    **33.48 ns** |     **1,236.7 ns** |     **1,301.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,377.6 ns |     61.27 ns |     3.36 ns |     1,374.6 ns |     1,381.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,614.7 ns |     71.18 ns |     3.90 ns |     1,610.3 ns |     1,617.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,564.3 ns |    172.79 ns |     9.47 ns |     2,557.1 ns |     2,575.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.7 ns |     30.91 ns |     1.69 ns |       200.8 ns |       204.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.4 ns |     19.70 ns |     1.08 ns |       284.7 ns |       286.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       490.8 ns |     19.15 ns |     1.05 ns |       490.2 ns |       492.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,162.8 ns** |  **6,551.43 ns** |   **359.11 ns** | **1,553,942.6 ns** | **1,554,577.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,901.6 ns |  2,711.92 ns |   148.65 ns |   617,740.8 ns |   618,033.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,401.7 ns | 17,936.53 ns |   983.16 ns |   658,356.4 ns |   660,307.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,385,389.7 ns | 77,476.25 ns | 4,246.73 ns | 1,382,871.3 ns | 1,390,292.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,278.6 ns |  2,225.64 ns |   122.00 ns |   163,138.3 ns |   163,359.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,175.2 ns |  7,082.17 ns |   388.20 ns |    91,842.9 ns |    92,601.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,858.0 ns |  6,735.22 ns |   369.18 ns |    65,630.6 ns |    66,284.0 ns |      - |      40 B |
