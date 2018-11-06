using System;
using JustSaying.AwsTools;
using Shouldly;
using Xunit;

namespace JustSaying.UnitTests.AwsTools
{
    public class JustSayingConstantsTests
    {
        [Fact]
        public void DefaultsAreAsTheyShouldBe()
        {
            JustSayingConstants.DEFAULT_ATTRIBUTE_ENCRYPTION_KEY_ID.ShouldBe("alias/aws/sqs");
            JustSayingConstants.DEFAULT_ATTRIBUTE_ENCRYPTION_KEY_REUSE_PERIOD_SECOND.ShouldBe("300");
            JustSayingConstants.DEFAULT_HANDLER_RETRY_COUNT.ShouldBe(5);
            JustSayingConstants.DEFAULT_PUBLISHER_RETRY_COUNT.ShouldBe(3);
            JustSayingConstants.DEFAULT_PUBLISHER_RETRY_INTERVAL.ShouldBe(Convert.ToInt32(TimeSpan.FromMilliseconds(100).TotalMilliseconds));
            JustSayingConstants.DEFAULT_RETENTION_PERIOD.ShouldBe(Convert.ToInt32(TimeSpan.FromDays(4).TotalSeconds));
            JustSayingConstants.DEFAULT_VISIBILITY_TIMEOUT.ShouldBe(Convert.ToInt32(TimeSpan.FromSeconds(30).TotalSeconds));
        }
    }
}
