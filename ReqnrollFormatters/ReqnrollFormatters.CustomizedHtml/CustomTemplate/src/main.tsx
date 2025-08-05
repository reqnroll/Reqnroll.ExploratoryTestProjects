import './styles.scss'

import { Envelope } from '@cucumber/messages'
import {
    EnvelopesProvider,
    ExecutionSummary,
    FilteredDocuments,
    SearchBar,
    UrlSearchProvider,
    CustomRendering,
} from '@cucumber/react-components'
import React from 'react'
import { createRoot } from 'react-dom/client'

declare global {
    interface Window {
        CUCUMBER_MESSAGES: Envelope[]
    }
}

const root = createRoot(document.getElementById('content') as HTMLElement)

// Customizeation example: render doc strings in a textarea, 
// see https://github.com/cucumber/react-components?tab=readme-ov-file#custom-rendering
root.render(
    <CustomRendering overrides={{
        DocString: (props) => (
            <>
                <p>I am going to render this doc string in a textarea:</p>
                <textarea>{props.docString.content}</textarea>
            </>
        )
    }}>
        <EnvelopesProvider envelopes={window.CUCUMBER_MESSAGES}>
            <UrlSearchProvider>
                <div id="report" className="html-formatter">
                    <div className="html-formatter__header">
                        <ExecutionSummary />
                        <SearchBar />
                    </div>
                    <FilteredDocuments />
                </div>
            </UrlSearchProvider>
        </EnvelopesProvider>
    </CustomRendering>
)
