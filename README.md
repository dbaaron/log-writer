## LogWriter
Simple thread safe logging class library in C#

### Required App Settings

To use this library you need the following 4 items in your App.config file:

```
<appSettings>
	<add key="LogPath" value="{path-to-logs}" />
	<add key="LogFile" value="{name-of-log-file}" />
	<add key="FlushAtAge" value="{time-to-flush-queue-at}" />
	<add key="FlushAtQty" value="{qty-to-flush-queue-at}" />
</appSettings>
```