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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,322.9 ns** |     **20.01 ns** |     **1.10 ns** |     **1,322.2 ns** |     **1,324.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,487.0 ns |     76.98 ns |     4.22 ns |     1,483.3 ns |     1,491.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,705.9 ns |     63.16 ns |     3.46 ns |     1,703.1 ns |     1,709.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,700.0 ns |     16.40 ns |     0.90 ns |     2,698.9 ns |     2,700.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.1 ns |     41.90 ns |     2.30 ns |       200.3 ns |       204.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       317.8 ns |     20.31 ns |     1.11 ns |       316.6 ns |       318.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       500.0 ns |     38.00 ns |     2.08 ns |       498.6 ns |       502.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,014.1 ns** |  **5,253.30 ns** |   **287.95 ns** | **1,545,800.7 ns** | **1,546,341.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,279.3 ns |  1,033.05 ns |    56.62 ns |   614,216.3 ns |   614,326.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,073.9 ns |  2,628.08 ns |   144.05 ns |   654,907.6 ns |   655,160.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,486.0 ns | 36,243.60 ns | 1,986.63 ns | 1,372,533.0 ns | 1,376,504.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,746.9 ns | 14,425.69 ns |   790.72 ns |   162,231.4 ns |   163,657.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,432.2 ns |    846.14 ns |    46.38 ns |    91,384.1 ns |    91,476.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,533.5 ns |  8,880.11 ns |   486.75 ns |    65,242.0 ns |    66,095.4 ns |      - |      40 B |
