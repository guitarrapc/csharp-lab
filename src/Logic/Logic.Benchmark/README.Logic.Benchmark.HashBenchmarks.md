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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,230.1 ns** |     **78.53 ns** |     **4.30 ns** |     **1,225.3 ns** |     **1,233.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,378.6 ns |     18.48 ns |     1.01 ns |     1,377.6 ns |     1,379.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,581.6 ns |     21.74 ns |     1.19 ns |     1,580.6 ns |     1,582.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,555.4 ns |    152.16 ns |     8.34 ns |     2,549.2 ns |     2,564.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       255.4 ns |     36.05 ns |     1.98 ns |       253.2 ns |       257.0 ns | 0.0067 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.3 ns |     15.94 ns |     0.87 ns |       287.5 ns |       289.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       478.2 ns |     20.70 ns |     1.13 ns |       476.9 ns |       478.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,070.5 ns** |  **4,989.09 ns** |   **273.47 ns** | **1,553,901.9 ns** | **1,554,386.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,456.0 ns |    235.23 ns |    12.89 ns |   617,446.8 ns |   617,470.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,709.8 ns |  2,302.52 ns |   126.21 ns |   658,632.9 ns |   658,855.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,479.0 ns | 39,129.89 ns | 2,144.84 ns | 1,380,030.6 ns | 1,383,943.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,582.4 ns |  6,400.24 ns |   350.82 ns |   163,177.9 ns |   163,804.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,078.8 ns |  1,488.49 ns |    81.59 ns |    91,994.9 ns |    92,157.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    66,102.5 ns |  6,269.43 ns |   343.65 ns |    65,707.9 ns |    66,336.5 ns |      - |      40 B |
