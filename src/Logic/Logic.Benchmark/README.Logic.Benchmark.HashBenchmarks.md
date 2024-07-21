```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,313.0 ns** |    **271.09 ns** |    **14.86 ns** |     **1,303.8 ns** |     **1,330.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,459.9 ns |     62.51 ns |     3.43 ns |     1,456.0 ns |     1,462.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,701.3 ns |     81.64 ns |     4.48 ns |     1,697.7 ns |     1,706.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,672.2 ns |    163.22 ns |     8.95 ns |     2,664.1 ns |     2,681.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       204.9 ns |     72.86 ns |     3.99 ns |       200.6 ns |       208.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.8 ns |     59.08 ns |     3.24 ns |       285.8 ns |       291.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       508.9 ns |     47.40 ns |     2.60 ns |       507.3 ns |       511.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,861.5 ns** |    **697.93 ns** |    **38.26 ns** | **1,545,834.1 ns** | **1,545,905.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,454.3 ns |  4,024.54 ns |   220.60 ns |   614,199.6 ns |   614,582.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,438.4 ns |  7,430.23 ns |   407.28 ns |   655,154.1 ns |   655,904.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,371,943.1 ns |  5,345.30 ns |   292.99 ns | 1,371,628.9 ns | 1,372,208.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,002.4 ns | 22,719.33 ns | 1,245.32 ns |   162,270.4 ns |   164,440.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,641.7 ns |  4,192.42 ns |   229.80 ns |    91,381.6 ns |    91,817.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,251.1 ns |  2,986.58 ns |   163.70 ns |    65,062.0 ns |    65,346.0 ns |      - |      40 B |
